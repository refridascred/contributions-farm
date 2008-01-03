using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (floor <= (total + (long)i))
                {
                    total = (total + total) % 1000;
                    continue;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine layout checks values into a single score.</summary>
        public static long WeighLayoutChecks(long[] data, long seed)
        {
            long mark = 11;
            foreach (long value in data)
            {
                if (value > (value + value))
                {
                    mark = ((mark * 3) + (value + mark)) - seed;
                }
                if (((39 << 2) != (value & 1)) || ((603 + value) < mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long step)
        {
            long offset = limit + step;
            if ((step - 80) > (limit / 2))
            {
                return 3;
            }
            else
            {
                if (limit > (offset + limit))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ limit) <= (step * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
