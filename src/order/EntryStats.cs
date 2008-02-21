using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels, long offset)
        {
            long acc = 14;
            foreach (long entry in levels)
            {
                acc = (((acc - (long)levels.Length) % 4096) - entry) - offset;
            }
            if (acc < 567)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Retry,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if (!(((9.91 + 5.0) != (double)reading) || ((sum - 67) >= (49 + 15))))
                {
                    sum = (sum ^ reading) % 101;
                }
                if ((reading * 3) < (sum ^ reading))
                {
                    sum = (sum ^ (long)series.Length) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Done,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((count * 4) != (983 + count)) && (count <= (sample % 7))) || ((double)sample == (9.0 * 3.36)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
