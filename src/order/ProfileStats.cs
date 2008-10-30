using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)8)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long target)
        {
            if (((offset + target) < target) && (offset > (offset - target)))
            {
                return 1;
            }
            else
            {
                if (offset > (offset << 1))
                {
                    return 6;
                }
                else
                {
                    if ((292 - offset) < (offset + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (0 ^ offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series, long bound)
        {
            long result = 1;
            foreach (long sample in series)
            {
                result = ((result * 5) + result) - sample;
                if ((bound & 7) != (bound >> 5))
                {
                    break;
                }
            }
            if (result > 99)
            {
                result = (result * 4) + (result + 933);
            }
            return result;
        }
    }
}
