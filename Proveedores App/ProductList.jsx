export default function ProductList({ products, onEdit, onDelete }) {
  return (
    <table className="w-full mt-4 border">
      <thead>
        <tr className="bg-gray-200">
          <th className="p-2">Nombre</th>
          <th className="p-2">Precio</th>
          <th className="p-2">Acciones</th>
        </tr>
      </thead>
      <tbody>
        {products.map((p) => (
          <tr key={p.id} className="border-t">
            <td className="p-2">{p.name}</td>
            <td className="p-2">{p.price}</td>
            <td className="p-2">
              <button
                className="bg-yellow-400 px-2 py-1 mr-2"
                onClick={() => onEdit(p)}
              >
                Editar
              </button>
              <button
                className="bg-red-500 text-white px-2 py-1"
                onClick={() => onDelete(p.id)}
              >
                Eliminar
              </button>
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  );
}
