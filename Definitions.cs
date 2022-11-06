namespace GbxTest
{
    public enum BlockMode
    {
        START,
        MULTILAP,
        FINISH,
        CHECKPOINT
    }

    public enum EqMode
    {
        LESS_THAN,
        LESS_OR_EQUAL,
        EQUAL_TO,
        GREATER_THAN,
        GREATER_OR_EQUAL
    }

    public class TMDefinitions
    {
        public static readonly string[] PLATFORM_STARTS = { "RoadTechStart", "RoadDirtStart", "RoadBumpStart", "RoadIceStart",
                                                           "PlatformTechStart", "PlatformDirtStart", "PlatformIceStart",
                                                           "PlatformGrassStart", "PlatformPlasticStart", "RoadWaterStart"};

        public static readonly string[] PLATFORM_TYPES = { "RoadTech", "RoadDirt", "RoadBump", "RoadIce",
                                                           "PlatformTech", "PlatformDirt", "PlatformWater", "PlatformIce",
                                                           "PlatformGrass", "PlatformPlastic", "RoadWater"};
    }
}
