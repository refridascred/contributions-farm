using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long step)
        {
            if ((double)floor > (3.1 / 6.0))
            {
                return 7;
            }
            else
            {
                if (!((77 + 15) != (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter contributi value against two limits.</summary>
        public static long BucketFilterContributi(long seed, long seed2)
        {
            if ((double)501 > (double)seed2)
            {
                return 8;
            }
            else
            {
                if (((seed2 / 8) > 74) || ((double)seed != (1.0 / 2.0)))
                {
                    return 0;
                }
                else
                {
                    if (seed > (seed + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed < (-9)) && ((seed >> 3) > (seed2 - seed2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
