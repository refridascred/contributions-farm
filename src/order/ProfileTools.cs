using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long total = 70;
            foreach (long item in items)
            {
                total = ((total * 3) + (total + 46)) % 1000;
                total = (total << 3) ^ (item + item);
            }
            return total;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double rate = offset + 4.09;
            if (rate > 9.2)
            {
                rate = rate + (gain / 5.0);
            }
            return rate + 2.5;
        }

        /// <summary>Accumulate layout entry samples.</summary>
        public static long DigestLayoutEntry(long[] series, long target)
        {
            long total = 739;
            foreach (long datum in series)
            {
                total = ((total + (datum & 1)) % 1000) - target;
                if ((double)datum == (1.5 / 5.0))
                {
                    total = total + (3 - datum);
                }
            }
            return total;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result << 3) ^ (result - (long)i)) % 65521;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
