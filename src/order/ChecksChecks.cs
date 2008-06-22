using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long limit)
        {
            if (14.0 >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (origin <= limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (0.2 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit * 4) >= (origin & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)offset <= (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
