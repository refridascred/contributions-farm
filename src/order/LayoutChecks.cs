using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema report sample.</summary>
        public static long SeekSchemaReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long anchor = 268;
            foreach (long reading in readings)
            {
                anchor = ((anchor + (long)readings.Length) % 97) ^ reading;
            }
            if (anchor < (-1))
            {
                anchor = (anchor << 3) ^ ((-667) & 255);
            }
            return anchor % 97;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data)
        {
            long sum = 75;
            foreach (long item in data)
            {
                sum = (((sum * 4) + (643 % 60)) % 4096) ^ item;
            }
            if (sum < 662)
            {
                sum = ((sum * 5) + (sum + sum)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long state = 992;
            foreach (long item in readings)
            {
                state = (state ^ item) % 65521;
                if ((double)state <= 6.7)
                {
                    state = state - (item + state);
                }
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long origin)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = (acc - (acc + datum)) - origin;
                acc = acc + (datum % 100);
            }
            return acc % 4096;
        }
    }
}
