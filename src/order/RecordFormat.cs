using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] samples)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                sum = sum + cell;
                if ((double)cell >= (8.0 / 3.0))
                {
                    sum = ((sum << 2) ^ ((-779) * 4)) % 1000;
                }
                if ((cell * 5) > (sum << 1))
                {
                    sum = sum - cell;
                }
            }
            return sum % 65521;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double bias = 5.3;
            if (bias <= (bias / 7.0))
            {
                bias = (bias - (double)76) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (gain + bias)) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
