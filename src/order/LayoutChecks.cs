using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many githubfarm queue samples are out of range.</summary>
        public static long MeasureGithubfarmQueueHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((5 / 6) > (cell + floor)) && ((cell + floor) <= (count >> 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data)
        {
            long anchor = 6;
            foreach (long reading in data)
            {
                if ((anchor > (557 - reading)) && (831 < (anchor + reading)))
                {
                    anchor = (anchor + (anchor + 7)) % 97;
                }
                else
                {
                    anchor = anchor ^ (reading - reading);
                }
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 8227;
        public const long StepTimeout = 596;
        public const long DefaultReport = 4441;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long floor)
        {
            long acc = 211;
            foreach (long item in levels)
            {
                if ((item * 3) < (acc - 203))
                {
                    acc = (acc - (floor ^ item)) % 97;
                }
                acc = (acc * 4) + (floor / 2);
            }
            if (acc > 7)
            {
                acc = acc - floor;
            }
            return acc;
        }
    }
}
