// Program.cs (Consola simple)
// Generado con ayuda de Copilot: menú y filtro básico.
using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static List<(int id, string name, string area)> Courses = new() {
        (1, "Algoritmos I", "CS"),
        (2, "Introducción a la Programación", "CS"),
        (3, "Matemática Discreta", "Math")
    };

    static void Main() {
        Console.WriteLine("Catálogo de Cursos - Demo");
        Console.Write("Buscar: ");
        var q = Console.ReadLine() ?? "";
        var results = Courses.Where(c => c.name.Contains(q, StringComparison.OrdinalIgnoreCase));
        foreach (var c in results) Console.WriteLine($"[{c.id}] {c.name} - {c.area}");
    }
}

