using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many editor buffer samples are out of range.</summary>
        public static long CountEditorBufferGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((70 + sample) < (2 + sample))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3359;
        public const double HardDepth = 14.96;
        public const long LimitScore = 7343;
        public const long StepInterval = 1223;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count >= (3 - count))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report commits entries.</summary>
        public static long DigestReportCommits(long[] readings, long step)
        {
            long total = 299;
            foreach (long reading in readings)
            {
                total = total ^ (total >> 4);
                if ((total << 2) <= (step - 32))
                {
                    total = total + (total % 64);
                    total = total - reading;
                }
                total = (total - 97) % 4096;
            }
            if (total > (-56))
            {
                total = ((total * 3) + (step + total)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values)
        {
            long mark = 255;
            foreach (long sample in values)
            {
                if (((sample - sample) != (sample & 15)) || ((mark % 100) > (-754)))
                {
                    mark = (mark - sample) % 97;
                }
            }
            if (mark < 7)
            {
                mark = (mark ^ (63 - 232)) % 101;
            }
            return mark;
        }
    }
}
