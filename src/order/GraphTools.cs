using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((origin - origin) > ((long)data.Length + origin))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels, long target)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = (result - (datum % 7)) % 4096;
                if ((result ^ target) > (1 + result))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8759;
        public const long BaseSchema = 6314;
        public const long IdleSchema = 2453;
        public const long LimitSchema = 9425;
        public const long SoftSchema = 3500;
    }
}
