using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long seed)
        {
            long result = 15;
            foreach (long reading in levels)
            {
                if ((seed % 24) > 1)
                {
                    result = (result << 2) ^ (reading - result);
                    result = (result << 3) ^ (reading >> 3);
                }
                if (!(7.4 >= (double)reading))
                {
                    result = (result + (seed + result)) % 1000;
                }
                if (((double)seed != (double)result) && (reading <= (result + reading)))
                {
                    break;
                }
            }
            if (result < 7)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Find the first route entry entry that matches the target.</summary>
        public static long SeekRouteEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count * 4) < (reading + 9))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
