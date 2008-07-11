using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate order contributi samples.</summary>
        public static long ScoreOrderContributi(long[] data, long step)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                if ((9 / 5) == (step - cell))
                {
                    break;
                }
                sum = ((sum * 5) + (sum ^ cell)) % 65521;
                if (cell < sum)
                {
                    sum = (sum ^ (-68)) % 65521;
                }
                else
                {
                    sum = (sum ^ (sum / 6)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double offset)
        {
            double scale = (double)(868 ^ 19);
            if (scale <= (double)4)
            {
                scale = (scale + 2.5) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long score = 30;
            foreach (long item in items)
            {
                score = ((score - score) % 65521) + item;
                score = (score + (678 / 3)) % 101;
            }
            if (score > 633)
            {
                score = score ^ (score * 5);
            }
            return score % 97;
        }
    }
}
