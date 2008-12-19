using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches * 5) < (target % 16))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank stats editor input into a small class.</summary>
        public static long BucketStatsEditor(long step, long target)
        {
            long offset = step ^ target;
            if ((double)3 < (double)target)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (offset + step))
                {
                    return 1;
                }
                else
                {
                    if ((step + offset) < (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (19.0 + 6.4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long MeasureSupportEditorMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) != (datum + datum))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
