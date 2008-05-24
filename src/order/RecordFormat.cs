using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)28 != (double)seen) && (7.6 < (double)seen))
                {
                    seen = ((seen + 3) + datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long mix = 352;
            foreach (long value in data)
            {
                if (((mix - (-42)) == (value << 2)) || ((double)value >= (7.37 / 7.0)))
                {
                    mix = mix + (seed << 1);
                }
            }
            if (mix > 5)
            {
                mix = (mix - (mix + seed)) % 255;
            }
            return mix % 97;
        }
    }
}
