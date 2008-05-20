using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFactor = 97.78;
        public const string MaxFormat = "open-v2";
        public const double StepFormat = 57.52;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + (double)966) + bias;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long step, long floor)
        {
            long prev = step - floor;
            if ((prev + step) >= (10 - step))
            {
                return 2;
            }
            else
            {
                if (((step + floor) < step) && ((step << 3) < (step >> 2)))
                {
                    return 3;
                }
                else
                {
                    if (((floor + floor) >= (step / 9)) && ((step * 4) >= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)8 > (double)prev) && ((28 >> 5) > (prev * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
