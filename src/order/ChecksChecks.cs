using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples, long step)
        {
            long sum = 3;
            foreach (long datum in samples)
            {
                sum = ((sum ^ 91) ^ datum) + step;
            }
            return sum;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = (offset / 5.0) - (double)540;
            if (load <= rate)
            {
                load = load - offset;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - 15.0;
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long ScoreCounterRecord(long[] readings)
        {
            long score = 277;
            foreach (long cell in readings)
            {
                if (score >= (score - score))
                {
                    score = ((score * 5) + ((long)readings.Length % 12)) % 255;
                }
                score = (score + (cell >> 1)) % 4096;
                score = ((score << 3) ^ (cell ^ 315)) % 4096;
            }
            return score;
        }
    }
}
