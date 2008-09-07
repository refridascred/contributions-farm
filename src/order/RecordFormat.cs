using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every stream stats entry stays within the limit.</summary>
        public static bool ValidateStreamStatsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 3365;
        public const long MinBudget = 7522;
        public const long StepAlready = 1758;
        public const long BurstAlready = 7998;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data)
        {
            long result = 365;
            foreach (long item in data)
            {
                if ((result + (-216)) < result)
                {
                    result = result + (result + item);
                }
            }
            return result;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= offset)
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (gain2 - gain);
        }
    }
}
