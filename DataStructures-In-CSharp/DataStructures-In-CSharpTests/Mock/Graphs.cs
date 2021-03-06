﻿using DataStructures_In_CSharp.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharpTests.Mock
{
    public class Graphs
    {
        public static Graph GetSampleGraph()
        {
            Graph graph = new Graph();
            Node fifth = new Node() { Name = "fifth", Childrens = null };
            Node forth = new Node() { Name = "forth", Childrens = new[] { fifth } };
            Node sixth = new Node() { Name = "sixth", Childrens = new[] { forth } };
            Node third = new Node() { Name = "third", Childrens = new[] { forth } };
            Node second = new Node() { Name = "second", Childrens = new[] { third } };
            Node first = new Node() { Name = "First", Childrens = new[] { second, forth } };
            graph.nodes = new Node[6];
            graph.nodes[0] = first;
            graph.nodes[1] = second;
            graph.nodes[2] = third;
            graph.nodes[3] = forth;
            graph.nodes[4] = fifth;
            graph.nodes[5] = sixth;
            return graph;
        }
    }
}
