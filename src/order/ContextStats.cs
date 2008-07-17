using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Idle,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long target, long origin)
        {
            if ((double)origin >= (4.2 + 1.48))
            {
                return 3;
            }
            else
            {
                if ((493 + target) >= (origin % 12))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (177 > (seen + datum))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Idle,
            Active,
            Queued,
        }
    }
}
