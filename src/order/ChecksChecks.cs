using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Paused,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long seed2)
        {
            long span = seed + seed2;
            if ((seed + seed2) == (span + seed2))
            {
                return 7;
            }
            else
            {
                if ((9.6 + 20.0) <= (double)seed2)
                {
                    return 3;
                }
                else
                {
                    if (((seed + span) < span) && ((seed2 >> 2) > seed2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3 + 176) != (span & 1)) || (seed2 >= (span * 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long FoldBatchesTools(long[] samples)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                if ((97 + 898) <= total)
                {
                    total = ((total - ((long)samples.Length >> 4)) % 1000) ^ datum;
                }
                else
                {
                    total = (total << 2) ^ (total + total);
                }
            }
            return total;
        }
    }
}
