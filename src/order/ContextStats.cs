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

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double scale = (weight * 4.1) - (weight * 3.1);
            if (scale > weight)
            {
                scale = (scale - 19.0) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (double)9;
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
