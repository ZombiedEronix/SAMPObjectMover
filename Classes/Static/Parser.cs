using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ObjectMover
{
    public static class Parser
    {

        public static GameCoordinate ParseToGameCoordinate(string coordinates)
        {
            string[] parameters = coordinates.Split(',').Select(p => p.Trim()).ToArray();

            if (parameters.Length < 4)
            {
                CrashDialog.Show(ErrorCode.NotParsed);
                return default;
            }

            switch (Parser.GetObjectType(coordinates))
            {
                case ObjectType.CreateObject:
                    return ParseCreateObject(parameters);
                case ObjectType.CreateDynamicObject:
                    return ParseCreateDynamicObject(parameters);
                default:
                    CrashDialog.Show(ErrorCode.NotParsed);
                    return default;
            }

        }

        private static GameCoordinate ParseCreateObject(string[] parameters)
        {
            string modelIdRaw = Regex.Match(parameters[0], @"-?\d+").Value;

            int.TryParse(modelIdRaw, NumberStyles.Integer, CultureInfo.InvariantCulture, out int modelID);
            float.TryParse(parameters[1], NumberStyles.Float, CultureInfo.InvariantCulture, out float x);
            float.TryParse(parameters[2], NumberStyles.Float, CultureInfo.InvariantCulture, out float y);
            float.TryParse(parameters[3], NumberStyles.Float, CultureInfo.InvariantCulture, out float z);

            float rx = 0, ry = 0, rz = 0;
            float streamDistance = 128.0f;

            if (parameters.Length >= 7)
            {
                float.TryParse(parameters[4], NumberStyles.Float, CultureInfo.InvariantCulture, out rx);
                float.TryParse(parameters[5], NumberStyles.Float, CultureInfo.InvariantCulture, out ry);
                float.TryParse(parameters[6], NumberStyles.Float, CultureInfo.InvariantCulture, out rz);
            }
            if (parameters.Length >= 8)
            {
                string streamDistanceRaw = Regex.Match(parameters[8], @"-?\d+").Value;

                float.TryParse(streamDistanceRaw, NumberStyles.Float, CultureInfo.InvariantCulture, out streamDistance);
            }

            return new GameCoordinate
            {
                ModelID = modelID,
                position = new Vector3(x, y, z),
                rotation = new Vector3(rx, ry, rz),
                StreamDistance = streamDistance
            };

        }

        private static GameCoordinate ParseCreateDynamicObject(string[] parameters)
        {
            string modelIdRaw = Regex.Match(parameters[0], @"-?\d+").Value;
            float rx = 0, ry = 0, rz = 0;
            int virtualWorld = -1;
            float streamDistance = 128.0f;

            int.TryParse(modelIdRaw, NumberStyles.Integer, CultureInfo.InvariantCulture, out int modelID);

            float.TryParse(parameters[1], NumberStyles.Float, CultureInfo.InvariantCulture, out float x);
            float.TryParse(parameters[2], NumberStyles.Float, CultureInfo.InvariantCulture, out float y);
            float.TryParse(parameters[3], NumberStyles.Float, CultureInfo.InvariantCulture, out float z);

            if (parameters.Length >= 7)
            {
                float.TryParse(parameters[4], NumberStyles.Float, CultureInfo.InvariantCulture, out rx);
                float.TryParse(parameters[5], NumberStyles.Float, CultureInfo.InvariantCulture, out ry);
                float.TryParse(parameters[6], NumberStyles.Float, CultureInfo.InvariantCulture, out rz);
            }
            if (parameters.Length >= 8)
            {
                int.TryParse(parameters[7], NumberStyles.Integer, CultureInfo.InvariantCulture, out virtualWorld);
            }
            if (parameters.Length >= 9)
            {
                string streamDistanceRaw = Regex.Match(parameters[8], @"-?\d+").Value;

                float.TryParse(streamDistanceRaw, NumberStyles.Float, CultureInfo.InvariantCulture, out streamDistance);
            }

            return new GameCoordinate
            {
                ModelID = modelID,
                position = new Vector3(x, y, z),
                rotation = new Vector3(rx, ry, rz),
                VirtualWorld = virtualWorld,
                StreamDistance = streamDistance
            };
        }

        internal static ObjectType GetObjectType(string v)
        {
            if (v.Contains("CreateObject"))
            {
                return ObjectType.CreateObject;
            }
            else if (v.Contains("CreateDynamicObject"))
            {
                return ObjectType.CreateDynamicObject;
            }
            else
            {
                CrashDialog.Show(ErrorCode.NotParsed);
                return ObjectType.Unknown;
            }
        }
    }
}