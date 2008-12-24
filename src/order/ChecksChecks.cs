using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = 2.3;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - (floor * 4.82);
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Combine payload account values into a single score.</summary>
        public static long TallyPayloadAccount(long[] data, long origin)
        {
            long state = 8;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state + (entry / 9)) ^ (long)i) - origin;
                }
                if ((entry & 15) <= (state - state))
                {
                    state = (state - (state / 5)) % 255;
                }
            }
            return state;
        }
    }
}
