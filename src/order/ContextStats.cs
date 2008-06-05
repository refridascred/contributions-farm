using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheInterval = 2423;
        public const string MinQueue = "staging-1";
        public const long StepQueue = 2683;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long step)
        {
            long result = 1;
            foreach (long entry in readings)
            {
                if (!((step - entry) >= 99))
                {
                    result = result - ((long)readings.Length >> 1);
                }
                if (step > (step - step))
                {
                    result = (result * 2) + (19 & 1);
                }
                if ((step - step) < (entry / 5))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result * 5) + step;
            }
            return result % 4096;
        }

        /// <summary>Measure how many schema payload samples are out of range.</summary>
        public static long MeasureSchemaPayloadOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry < (seen - entry)) && ((entry ^ seed) >= seen))
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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading / 2) >= (reading * 4))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
