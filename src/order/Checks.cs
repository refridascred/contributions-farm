using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleWidth = 4570;
        public const long StepGithubfarm = 9631;
        public const string BaseGithubfarm = "legacy";
        public const double MaxLevel = 55.17;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((0.8 * 2.0) > (double)seen) || (52 < (seen - value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((6.6 * 0.65) == (double)target)
                {
                    result = (result << 3) ^ target;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
