using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next cluster filter value from a seed.</summary>
        public static long IterateClusterFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i & 7) > (state & 31)) || ((double)(long)i < (7.4 + 7.3)))
                {
                    state = (state + (offset / 4)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + 1)) % 65521;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4573;
        public const long BatchFactor = 5151;
        public const long MinBatch = 4188;
        public const double HardLevel = 66.02;

        /// <summary>Count graph command pairs that satisfy a relation.</summary>
        public static long PairGraphCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count already cluster pairs that satisfy a relation.</summary>
        public static long PairAlreadyClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
