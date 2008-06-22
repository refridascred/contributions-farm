using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((881 >= (mark - mark)) && ((mark * 4) < (mark >> 5)))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (2.0 + 8.3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (51 > (seen - 8))
                {
                    seen = ((seen + 1) ^ entry) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Dropped,
            Paused,
            Idle,
        }
    }
}
