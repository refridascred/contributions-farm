using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long result = 14;
            foreach (long cell in readings)
            {
                result = (result ^ (cell + result)) % 4096;
                if ((289 / 2) > result)
                {
                    result = result ^ result;
                }
            }
            return result % 97;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long origin2)
        {
            long lane = origin - origin2;
            if ((11.0 / 3.0) < (double)origin2)
            {
                return 7;
            }
            else
            {
                if ((origin - lane) > (lane << 3))
                {
                    return 4;
                }
                else
                {
                    if (!((lane << 2) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + origin2) == (origin2 + lane))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((step & 127) < (item & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxWidth = 66.19;
        public const double WindowProfile = 90.3;
        public const long MaxProfile = 8766;
        public const long CacheWidth = 5546;
    }
}
