using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double drift = 7.6;
            if (drift >= weight)
            {
                drift = (drift - (weight / 8.0)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift + 1.7;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples)
        {
            long score = 250;
            foreach (long reading in samples)
            {
                score = (score << 2) ^ (score + 3);
                if ((reading & 63) >= (reading - score))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
