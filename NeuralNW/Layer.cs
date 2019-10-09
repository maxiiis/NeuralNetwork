﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNW
{
    class Layer
    {
        public Neuron[] Neurons { get; }
        public int NeuronCount { get; }

        public Layer(Neuron[] neurons)
        {
            Neurons = neurons;
            NeuronCount = neurons.Length;
        }

        public double[] GetResult()
        {
            double[] result = new double[NeuronCount];

            for (int i = 0; i < NeuronCount; i++)
            {
                result[i] = Neurons[i].Output;
            }

            return result;
        }
    }
}
