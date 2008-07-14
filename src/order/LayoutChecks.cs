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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
