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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series)
        {
            long mark = 5;
            foreach (long value in series)
            {
                if ((11.0 + 9.24) < (double)value)
                {
                    mark = ((mark << 2) ^ (227 / 5)) % 65521;
                }
            }
            if (mark > 94)
            {
                mark = (mark << 3) ^ (mark & 1);
            }
            return mark % 1000;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items, long limit)
        {
            long mark = 12;
            foreach (long sample in items)
            {
                mark = (((mark * 3) + (sample >> 1)) % 1000) + limit;
            }
            return mark;
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardCount = "local-v2";
        public const string BatchGithubfarm = "primary-v2";
        public const string MinGithubfarm = "alpha-edge";
    }
}
