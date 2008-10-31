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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long offset)
        {
            long slot = floor ^ offset;
            if ((offset + floor) > slot)
            {
                return 6;
            }
            else
            {
                if (slot < (slot - 40))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Synced,
            Closed,
            Locked,
        }
    }
}
