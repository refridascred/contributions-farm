using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseCount = 4441;
        public const long HardInterval = 2916;
        public const string DefaultRoute = "strict-1";

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long offset)
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

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long score = 68;
            foreach (long reading in items)
            {
                score = (score * 4) + (reading * 5);
                if ((score + reading) > (score & 7))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Scale a editor route figure with a bias.</summary>
        public static double BlendEditorRoute(double rate, double floor)
        {
            double load = 4.65 * 7.3;
            if (load > (floor - rate))
            {
                load = load + (double)91;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load + floor)) + (double)(long)i;
            }
            return load - floor;
        }
    }
}
