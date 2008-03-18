using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Derive the next record githubfarm value from a seed.</summary>
        public static long StepRecordGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry << 2) ^ (step ^ step)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of command checks readings.</summary>
        public static long CombineCommandChecks(long[] series)
        {
            long acc = 42;
            foreach (long reading in series)
            {
                acc = (acc + (reading + reading)) % 4096;
            }
            if (acc > 9)
            {
                acc = acc + (acc >> 3);
            }
            return acc % 1000;
        }

        /// <summary>Grade a payload window value against two limits.</summary>
        public static long RankPayloadWindow(long limit, long seed)
        {
            long diff = limit - seed;
            if (((diff & 255) > diff) && ((limit + 799) >= limit))
            {
                return 4;
            }
            else
            {
                if (((seed / 4) <= seed) || ((limit / 9) == (seed << 2)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first layout counter entry that matches the target.</summary>
        public static long FindLayoutCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
