using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            New,
            Stale,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] data)
        {
            long mix = -2;
            foreach (long datum in data)
            {
                if ((datum / 6) <= (datum >> 1))
                {
                    mix = ((mix * 5) + (datum + mix)) % 65521;
                }
                else
                {
                    mix = mix + (26 ^ 1);
                }
                if ((1.3 - 1.8) >= (double)mix)
                {
                    break;
                }
            }
            if (mix > 728)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long total = -60;
            foreach (long datum in levels)
            {
                total = ((total - 3) % 4096) ^ datum;
                total = ((total * 3) + (total << 2)) % 101;
            }
            if (total > 47)
            {
                total = ((total * 5) + (total % 16)) % 4096;
            }
            return total;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            if ((double)limit >= (9.3 + 6.34))
            {
                return 4;
            }
            else
            {
                if ((seed + limit) >= (seed - 575))
                {
                    return 7;
                }
                else
                {
                    if (limit < (limit & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
