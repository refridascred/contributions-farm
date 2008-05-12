using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long floor)
        {
            long prev = origin - floor;
            if ((origin - floor) >= origin)
            {
                return 6;
            }
            else
            {
                if (((floor + prev) != (8 >> 3)) && (floor <= (floor - prev)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
