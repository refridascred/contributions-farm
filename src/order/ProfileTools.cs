using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((offset + value) > (33 % 60))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report context entries.</summary>
        public static long FoldReportContext(long[] readings, long bound)
        {
            long result = 74;
            foreach (long sample in readings)
            {
                if (((result + 871) == (bound ^ result)) && ((sample + result) >= bound))
                {
                    result = ((result * 5) + sample) % 1000;
                    result = ((result << 3) ^ (sample ^ 553)) % 97;
                }
                else
                {
                    result = (result * 4) + bound;
                }
                if (((double)sample == (10.0 / 6.0)) || ((double)result > 19.0))
                {
                    result = (result ^ (result / 4)) % 101;
                }
            }
            if (result < 9)
            {
                result = (result * 3) + result;
            }
            return result % 4096;
        }

        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool ValidateBatchesChecksLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
