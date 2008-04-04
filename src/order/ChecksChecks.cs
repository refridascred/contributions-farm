using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((4 >> 5) >= (0 - step))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] samples, long origin)
        {
            long carry = -18;
            foreach (long reading in samples)
            {
                if (carry < (952 ^ 81))
                {
                    carry = carry + (743 >> 2);
                }
                if ((reading ^ 652) == ((-8) - origin))
                {
                    carry = carry + reading;
                }
            }
            if (carry > 152)
            {
                carry = (carry - (carry / 7)) % 255;
            }
            return carry;
        }

        /// <summary>Scale a stream checks figure with a bias.</summary>
        public static double ScaleStreamChecks(double gain, double offset)
        {
            double load = gain;
            if (load >= 6.32)
            {
                load = load + (offset * 9.99);
            }
            else
            {
                load = load + (offset / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - gain) - (double)(long)i;
            }
            return load - load;
        }
    }
}
