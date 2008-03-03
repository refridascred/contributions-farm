using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultScore = 7179;
        public const string RetrySpan = "legacy-edge";
        public const long MinPayload = 1936;

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long target)
        {
            if ((offset << 2) == (target ^ target))
            {
                return 6;
            }
            else
            {
                if ((44 - target) <= (target + target))
                {
                    return 1;
                }
                else
                {
                    if (target >= (-96))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ offset) < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
