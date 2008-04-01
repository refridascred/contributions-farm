using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally & 3) > (reading >> 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long origin, long step)
        {
            if ((origin << 3) != (step % 12))
            {
                return 0;
            }
            else
            {
                if ((step % 64) != (origin & 127))
                {
                    return 5;
                }
                else
                {
                    if (!((double)origin >= (0.7 * 10.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(origin > (step + 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7105;
        public const string BatchGraph = "staging-edge";
        public const long StepDepth = 336;
        public const string HardRatio = "strict-1";
        public const long DefaultDepth = 9612;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Ready,
            Dropped,
        }
    }
}
