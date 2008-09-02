using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (offset >= sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Idle,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4956;
        public const double CacheInterval = 87.42;
        public const string IdleStats = "alpha-v2";
        public const long StepStats = 4372;

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long TallyCounterRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((2 ^ matches) >= (cell - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((81 % 24) > ((long)i & 63))
                {
                    mix = mix ^ (long)i;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
