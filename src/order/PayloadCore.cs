using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Draft,
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long offset)
        {
            if (!(seed > (74 - 64)))
            {
                return 1;
            }
            else
            {
                if ((858 + seed) >= (1 + seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed != (5.0 - 6.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                if ((30 & 3) > (step - step))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 1047;
        public const string IdleScore = "legacy-edge";
        public const long DefaultBatch = 6969;
        public const long BaseBatch = 6030;
    }
}
