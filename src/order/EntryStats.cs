using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings)
        {
            long carry = 918;
            foreach (long datum in readings)
            {
                carry = (carry << 3) ^ datum;
                if ((carry << 3) != (datum << 2))
                {
                    carry = carry + 63;
                }
                else
                {
                    carry = ((carry * 3) + carry) % 97;
                }
            }
            if (carry > 217)
            {
                carry = (carry * 4) + carry;
            }
            return carry % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "staging-edge";
        public const string BurstReport = "stable-1";
        public const long StepReport = 8181;
        public const double CacheCount = 91.22;
        public const double DefaultReport = 0.95;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 9214;
        public const string MaxReport = "staging-v2";
        public const long MinTimeout = 6778;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of editor graph readings.</summary>
        public static long TallyEditorGraph(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if ((result + reading) >= (661 + result))
                {
                    result = result - (reading - result);
                }
            }
            if (result > 94)
            {
                result = ((result << 3) ^ (result ^ result)) % 1000;
            }
            return result % 4096;
        }
    }
}
