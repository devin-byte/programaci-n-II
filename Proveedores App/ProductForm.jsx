import { useState, useEffect } from "react";
import { toast } from "react-toastify";

export default function ProductForm({ onSave, product }) {
  const [name, setName] = useState("");
  const [price, setPrice] = useState("");

  useEffect(() => {
    if (product) {
      setName(product.name);
      setPrice(product.price);
    }
  }, [product]);

  const handleSubmit = (e) => {
    e.preventDefault();

    if (!name || !price) {
      toast.error("Todos los campos son obligatorios");
      return;
    }

    onSave({ name, price });
    setName("");
    setPrice("");
  };

  return (
    <form onSubmit={handleSubmit} className="bg-white p-4 rounded shadow">
      <input
        type="text"
        placeholder="Nombre del producto"
        className="border p-2 w-full mb-2"
        value={name}
        onChange={(e) => setName(e.target.value)}
      />

      <input
        type="number"
        placeholder="Precio"
        className="border p-2 w-full mb-2"
        value={price}
        onChange={(e) => setPrice(e.target.value)}
      />

      <button className="bg-blue-500 text-white px-4 py-2 rounded">
        Guardar
      </button>
    </form>
  );
}
