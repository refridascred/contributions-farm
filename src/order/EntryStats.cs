using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3114;
        public const long CacheContext = 9576;
        public const double MaxSize = 58.46;
        public const long StepContext = 5156;

        /// <summary>Validate session context readings against a bound.</summary>
        public static bool VerifySessionContextBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 8830;
        public const string StepCount = "local-v2";
        public const double WindowCommand = 51.12;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double ratio = gain;
            return (ratio - (gain + gain)) + floor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry + entry) > (floor + floor)) && ((hits / 7) >= (hits / 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
