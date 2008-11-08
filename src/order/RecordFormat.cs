using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate report account samples.</summary>
        public static long ScoreReportAccount(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length > (cell - cell))
                {
                    acc = (acc ^ cell) % 101;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ 71;
            }
            return acc % 65521;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Fold a list of window queue readings.</summary>
        public static long CombineWindowQueue(long[] readings, long limit)
        {
            long total = 799;
            foreach (long reading in readings)
            {
                if ((38 > (7 - reading)) && ((reading & 255) == (total - limit)))
                {
                    total = ((total * 2) + (42 + 60)) % 65521;
                }
                else
                {
                    total = total - (6 ^ 90);
                }
            }
            return total;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)cell == (double)count) || ((cell & 7) < (count & 255)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
