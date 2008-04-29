using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 8109;
        public const long WindowContributi = 5517;
        public const long HardContributi = 2322;
        public const long IdleWidth = 4313;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((floor & 63) >= (seen % 60)) || !((double)(-367) > (double)seen))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm editor samples.</summary>
        public static long FoldGithubfarmEditor(long[] samples, long offset)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = ((mark ^ mark) - cell) - offset;
                if ((mark % 16) <= 2)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
