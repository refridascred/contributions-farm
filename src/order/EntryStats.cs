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

        /// <summary>Compare every pair of format order readings.</summary>
        public static long PairFormatOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Pending,
            Stale,
            Paused,
        }

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
