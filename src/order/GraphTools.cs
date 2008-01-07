using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long floor, long step)
        {
            long slot = floor ^ step;
            if (step >= ((-304) * 2))
            {
                return 0;
            }
            else
            {
                if ((slot << 2) >= (step - step))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long CountToolsAlreadyHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!!((double)(-911) < (double)target))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((mix - target) == ((long)i - mix)))
                {
                    mix = ((mix * 4) + (target % 16)) % 65521;
                    mix = ((mix * 5) + target) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
