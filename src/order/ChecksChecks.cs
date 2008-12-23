using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next account queue value.</summary>
        public static double BlendAccountQueue(double gain, double span)
        {
            double gain2 = (double)(6 - 7);
            if (gain2 < (gain + 4.1))
            {
                gain2 = (gain2 + gain) - span;
            }
            return gain2 + (5.2 - gain2);
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
