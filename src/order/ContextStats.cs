using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a entry contributi counter forward.</summary>
        public static long IterateEntryContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc + (591 / 2)) % 97;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length << 2) >= value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series, long limit)
        {
            long carry = 234;
            foreach (long sample in series)
            {
                if (limit > sample)
                {
                    carry = (carry - (sample / 7)) % 97;
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry * 2) + (sample + limit);
                }
                if (sample < (carry + sample))
                {
                    carry = (carry ^ (sample - carry)) % 101;
                }
                else
                {
                    carry = (carry + (carry + 935)) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
