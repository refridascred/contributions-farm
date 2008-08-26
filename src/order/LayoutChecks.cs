using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitSize = 9794;
        public const string DefaultNotes = "staging";
        public const long BaseNotes = 1738;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long mix = 50;
            foreach (long item in levels)
            {
                if (item < 444)
                {
                    mix = (mix + (mix >> 5)) - limit;
                }
                mix = (mix - (item / 7)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long offset)
        {
            long result = 23;
            foreach (long reading in readings)
            {
                result = (((result * 5) + (reading >> 5)) % 101) - offset;
            }
            return result;
        }

        /// <summary>Validate report already readings against a bound.</summary>
        public static bool VerifyReportAlreadyRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
