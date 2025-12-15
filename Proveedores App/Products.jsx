import { useEffect, useState } from "react";
import { getProducts, createProduct, updateProduct, deleteProduct } from "../api/productApi";
import ProductForm from "../components/ProductForm";
import ProductList from "../components/ProductList";
import { toast } from "react-toastify";

export default function Products() {
  const [products, setProducts] = useState([]);
  const [selected, setSelected] = useState(null);

  const loadProducts = async () => {
    const res = await getProducts();
    setProducts(res.data);
  };

  useEffect(() => {
    loadProducts();
  }, []);

  const handleSave = async (product) => {
    if (selected) {
      await updateProduct(selected.id, product);
      toast.success("Producto actualizado correctamente");
      setSelected(null);
    } else {
      await createProduct(product);
      toast.success("Producto creado correctamente");
    }
    loadProducts();
  };

  const handleDelete = async (id) => {
    await deleteProduct(id);
    toast.success("Producto eliminado");
    loadProducts();
  };

  return (
    <div className="max-w-4xl mx-auto p-4">
      <ProductForm onSave={handleSave} product={selected} />
      <ProductList products={products} onEdit={setSelected} onDelete={handleDelete} />
    </div>
  );
}
