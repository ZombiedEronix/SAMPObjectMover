using System.Globalization;

namespace ObjectMover
{
    public struct GameCoordinate
    {
        public Vector3 position { get; set; }
        public Vector3 rotation { get; set; }
        public int ModelID { get; set; }
        public int VirtualWorld { get; set; }
        public float StreamDistance { get; set; }

        public GameCoordinate(int model, Vector3 position, Vector3 rotation, int virtualWorld = 0, float streamDistance = 128)
        {
            this.position = position;
            this.rotation = rotation;
            ModelID = model;
            VirtualWorld = virtualWorld;

            if(streamDistance == 0)
            {
                StreamDistance = 128f;
            }
            else
            {
                StreamDistance = streamDistance;
            }
        }

        public GameCoordinate(int model, Vector3 position)
        {
            ModelID = model;
            this.position = position;

            this.rotation = new Vector3();
            this.VirtualWorld = -1;
            this.StreamDistance = 128f;
        }

        public GameCoordinate(int model, Vector3 position, Vector3 rotation)
        {
            ModelID = model;
            this.position = position;
            this.rotation = rotation;

            this.VirtualWorld = -1;
            this.StreamDistance = 128f;
        }

        public string ToMTA() =>
            string.Format(CultureInfo.InvariantCulture,
            "<object id=\"obj\" model=\"{0}\" posX=\"{1}\" posY=\"{2}\" posZ=\"{3}\" rotX=\"{4}\" rotY=\"{5}\" rotZ=\"{6}\" />",
            ModelID, position.x, position.y, position.z, rotation.x, rotation.y, rotation.z);

        public string ToCreateObject() =>
            string.Format(CultureInfo.InvariantCulture,
            "CreateObject({0}, {1:F3}, {2:F3}, {3:F3}, {4:F3}, {5:F3}, {6:F3}, {7:F2});",
            ModelID, position.x, position.y, position.z, rotation.x, rotation.y, rotation.z, StreamDistance);

        public string ToStreamer() =>
            string.Format(CultureInfo.InvariantCulture,
            "CreateDynamicObject({0}, {1:F3}, {2:F3}, {3:F3}, {4:F3}, {5:F3}, {6:F3}, {7}, {8 :F1});",
            ModelID, position.x, position.y, position.z, rotation.x, rotation.y, rotation.z, VirtualWorld, StreamDistance);
    }
}