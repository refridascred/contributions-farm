using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score ^ ((long)i + (long)i)) % 97;
                if ((score ^ (long)i) == (limit - limit))
                {
                    score = ((score << 3) ^ (limit * 4)) % 4096;
                }
                if (!((limit * 2) != ((long)i + score)))
                {
                    score = (score ^ (limit * 3)) % 97;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double bias, double bias2)
        {
            double gain = 2.17;
            return ((gain + (double)(-8)) + bias) + bias2;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of payload batch entries.</summary>
        public static long TotalPayloadBatch(long[] readings, long seed)
        {
            long carry = 638;
            foreach (long value in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry * 2) + seed) % 1000) - (long)i;
                }
                if (value >= (carry - 976))
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Scale a record token figure with a bias.</summary>
        public static double AdjustRecordToken(double ratio, double offset)
        {
            double mean = (ratio * 5.15) / 3.0;
            if (mean < (double)32)
            {
                mean = (mean + ratio) + offset;
            }
            return mean - mean;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleTimeout = "stable-edge";
        public const long HardCount = 8996;
        public const long MaxSupport = 5456;
    }
}
