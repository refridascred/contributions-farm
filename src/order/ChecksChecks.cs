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

        /// <summary>Fold a list of queue editor readings.</summary>
        public static long CombineQueueEditor(long[] data, long floor)
        {
            long result = 787;
            foreach (long entry in data)
            {
                if (((floor % 2) != (result + result)) && (floor < (floor - result)))
                {
                    result = ((result + result) % 1000) - entry;
                }
            }
            return result % 4096;
        }
    }
}
