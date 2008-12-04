using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            New,
            Dropped,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double floor)
        {
            double rate = (floor / 9.0) * 2.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (double)760) - (double)(long)i) - scale;
            }
            return rate + (double)5;
        }
    }
}
