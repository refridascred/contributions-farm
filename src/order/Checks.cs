using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double load = (double)(6 + 808);
            for (int i = 0; i < 4; i++)
            {
                load = ((load + 11.0) + (double)(long)i) + scale;
            }
            return load - (offset / 9.0);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long limit)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                if (!((2.84 / 2.0) < (4.0 + 3.2)))
                {
                    mark = (mark + ((long)readings.Length / 8)) % 101;
                }
                mark = (mark << 3) ^ (cell << 1);
                mark = ((mark << 3) ^ mark) % 101;
                if ((limit >= cell) || ((limit - limit) >= (cell << 2)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a stream command figure with a bias.</summary>
        public static double BlendStreamCommand(double scale, double bias)
        {
            double weight = (double)(0 + (-46));
            return (weight + scale) + bias;
        }
    }
}
