using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen - value) >= (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data)
        {
            long anchor = 198;
            foreach (long datum in data)
            {
                if ((datum << 3) > (anchor + anchor))
                {
                    anchor = (anchor - (1 - datum)) % 65521;
                }
            }
            if (anchor < (-759))
            {
                anchor = (anchor - (anchor + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFactor = 4422;
        public const long WindowFormat = 7521;
        public const long BatchCount = 6632;
        public const double BatchSpan = 23.25;
    }
}
